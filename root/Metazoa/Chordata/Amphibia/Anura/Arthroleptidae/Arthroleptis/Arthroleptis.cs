using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae.Arthroleptis;

/// <summary>
/// Abstract class for Arthroleptis (genus).
/// NCBI TaxId: 83975
/// </summary>
public abstract class Arthroleptis : Arthroleptidae, IArthroleptis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arthroleptis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83975;

    /// <inheritdoc />
    public virtual string GenusName => "Arthroleptis";

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
