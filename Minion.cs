using System;
using System.Collections.Generic;
using System.Text;

    public class Minion
    {
        string name;
        int id, magicRes, mrPerLvl, physRes, physresPerLvl, physDmg, physdmgPerLvl, magicDmg, magicdmgPerLvl, speed, speedPerLvl, maxhp, maxhpPerLvl, acthp, evasion, accuracy, penetration, durability, lvl;
        int evolveLvl, xp, lvlUpxp;

        Attack[] attacks;
        Attack uniqueAttack;

        Item heldItem, evolveItem;
        Skin skin;

        public Minion (int pid, int plvl)
        {
            magicRes = StatContainer.getmrPerLvl(pid)*plvl + StatContainer.getStartmagicRes(pid);
            physRes = StatContainer.getphyresPerLvl(pid) * plvl + StatContainer.getStartphysRes(pid);
            physDmg = StatContainer.getphysDmgPerLvl(pid) * plvl + StatContainer.getStartphyDmg(pid);
            magicDmg = StatContainer.getmagicDmgPerLvl(pid) * plvl + StatContainer.getStartmagicDmg(pid);
            speed = StatCpntainer.getspeedPerLvl(pid) * plvl + StatContainer.getStartspeed(pid);
            maxhp = StatContainer.getmaxhpPerLvl(pid) * plvl + StatContainer.getStartmaxhp(pid);
            acthp = maxhp;
            evasion = StatContainer.getEvasion(pid);
            accuracy = StatContainer.getAccuracy(pid);
            penetration = StatContainer.getPenetration(pid);
            durability = StatContainer.getDurability(pid);
            lvl = plvl;
            evolveLvl = StatContainer.getevolveLvl(pid);
            evolveItem = StatContainer.getevolveItem(pid);
            attacks = new Attack[4];
            uniqueAttack = StatContainer.getuniqueAttack(pid);
            skin = StatContainer.getSkin(pid);
        }

        public string getName ()
        {
            return name;
        }

        public void setName (string pName)
        {
            name = pName;
        }

        public int getmagicRes()
        {
            return magicRes;
        }

        public void setmagicRes(int pmagicRes)
        {
            magicRes = pmagigRes;
        }

        public int getphysRes()
        {
            return physRes;
        }

        public void setphysRes(int pphysRes)
        {
            physRes = pphysRes;
        }

        public int getphysDmg()
        {
            return physDmg;
        }

        public void setphysDmg(int pphysDmg)
        {
            physDmg = pphysDmg;
        }

        public int getmagicDmg()
        {
            return magicDmg;
        }

        public void setmagicDmg(int pmagicDmg)
        {
            magicDmg = pmagicDmg;
        }

        public int getSpeed ()
        {
            return speed;
        }

        public void setSpeed (int pspeed)
        {
            speed = pspeed;
        }

        public int getmaxhp ()
        {
            return maxhp;
        }

        public void setmaxhp (int pmaxhp)
        {
            maxhp = pmaxhp;
        }

        public int getacthp()
        {
            return acthp;
        }

        public void setacthp(int pacthp)
        {
            acthp = pacthp;
        } 

        public int getevasion ()
        {
            return evasion;
        }

        public void setevasion (int pevasion)
        {
            evasion = pevasion;
        }

        public int getaccuracy ()
        {
            return accuracy;
        }

        public void setaccuracy (int paccuracy)
        {
            accuracy = paccuracy;
        }
        
        public int getpenetration ()
        {
            return penetration;
        }

        public void setpenetration (int ppenetration)
        {
            penetration = ppenetration;
        }

        public int getdurability()
        {
            return durability;
        }

        public void setdurability(int pdurability)
        {
            durability = pdurability;
        }

        public int getlvl ()
        {
            return lvl;
        }

        /**
         * Missing level system
         **/
        public void lvlUp ()
        {
            ;
        }

        public bool canEvolve ()
        {
            return ((heldItem.equals(evolveItem) || evolveItem == null) && lvl >= evolveLvl);
        }

        /**
         * Missing evolve function
         **/

        public void evolve()
        {
            ;
        }






    }

