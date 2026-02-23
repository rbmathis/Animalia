using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Pristolepididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Pristolepididae.Pristolepis;

/// <summary>
/// Abstract class for Pristolepis (genus).
/// NCBI TaxId: 302776
/// </summary>
public abstract class Pristolepis : Pristolepididae, IPristolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pristolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 302776;

    /// <inheritdoc />
    public virtual string GenusName => "Pristolepis";

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
