using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Barycholos;

/// <summary>
/// Abstract class for Barycholos (genus).
/// NCBI TaxId: 356262
/// </summary>
public abstract class Barycholos : Craugastoridae, IBarycholos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barycholos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356262;

    /// <inheritdoc />
    public virtual string GenusName => "Barycholos";

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
