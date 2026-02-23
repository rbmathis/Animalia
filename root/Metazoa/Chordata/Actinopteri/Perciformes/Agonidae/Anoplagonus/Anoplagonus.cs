using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Anoplagonus;

/// <summary>
/// Abstract class for Anoplagonus (genus).
/// NCBI TaxId: 1154602
/// </summary>
public abstract class Anoplagonus : Agonidae, IAnoplagonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anoplagonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1154602;

    /// <inheritdoc />
    public virtual string GenusName => "Anoplagonus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
