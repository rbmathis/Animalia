using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Kassina;

/// <summary>
/// Abstract class for Kassina (genus).
/// NCBI TaxId: 8413
/// </summary>
public abstract class Kassina : Hyperoliidae, IKassina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kassina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8413;

    /// <inheritdoc />
    public virtual string GenusName => "Kassina";

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
