using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Oligolepis;

/// <summary>
/// Abstract class for Oligolepis (genus).
/// NCBI TaxId: 150311
/// </summary>
public abstract class Oligolepis : Gobiidae, IOligolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oligolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150311;

    /// <inheritdoc />
    public virtual string GenusName => "Oligolepis";

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
