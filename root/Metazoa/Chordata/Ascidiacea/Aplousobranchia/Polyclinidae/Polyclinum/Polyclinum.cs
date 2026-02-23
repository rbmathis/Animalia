using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polyclinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polyclinidae.Polyclinum;

/// <summary>
/// Abstract class for Polyclinum (genus).
/// NCBI TaxId: 201965
/// </summary>
public abstract class Polyclinum : Polyclinidae, IPolyclinum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polyclinum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201965;

    /// <inheritdoc />
    public virtual string GenusName => "Polyclinum";

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
