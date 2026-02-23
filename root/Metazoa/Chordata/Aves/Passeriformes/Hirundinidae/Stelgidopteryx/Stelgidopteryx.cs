using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Stelgidopteryx;

/// <summary>
/// Abstract class for Stelgidopteryx (genus).
/// NCBI TaxId: 72877
/// </summary>
public abstract class Stelgidopteryx : Hirundinidae, IStelgidopteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stelgidopteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 72877;

    /// <inheritdoc />
    public virtual string GenusName => "Stelgidopteryx";

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
