using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Platybelone;

/// <summary>
/// Abstract class for Platybelone (genus).
/// NCBI TaxId: 129058
/// </summary>
public abstract class Platybelone : Belonidae, IPlatybelone
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platybelone";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129058;

    /// <inheritdoc />
    public virtual string GenusName => "Platybelone";

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
