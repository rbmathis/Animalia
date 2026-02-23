using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Testudo;

/// <summary>
/// Abstract class for Testudo (genus).
/// NCBI TaxId: 86974
/// </summary>
public abstract class Testudo : Testudinidae, ITestudo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Testudo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86974;

    /// <inheritdoc />
    public virtual string GenusName => "Testudo";

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
