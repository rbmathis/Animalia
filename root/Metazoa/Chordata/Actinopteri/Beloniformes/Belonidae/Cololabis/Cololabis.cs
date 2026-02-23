using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Cololabis;

/// <summary>
/// Abstract class for Cololabis (genus).
/// NCBI TaxId: 129042
/// </summary>
public abstract class Cololabis : Belonidae, ICololabis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cololabis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129042;

    /// <inheritdoc />
    public virtual string GenusName => "Cololabis";

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
