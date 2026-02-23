using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Aphaniotis;

/// <summary>
/// Abstract class for Aphaniotis (genus).
/// NCBI TaxId: 89035
/// </summary>
public abstract class Aphaniotis : Agamidae, IAphaniotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphaniotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89035;

    /// <inheritdoc />
    public virtual string GenusName => "Aphaniotis";

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
