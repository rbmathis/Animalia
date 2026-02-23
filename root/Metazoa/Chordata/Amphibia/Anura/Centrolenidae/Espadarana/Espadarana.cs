using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Espadarana;

/// <summary>
/// Abstract class for Espadarana (genus).
/// NCBI TaxId: 715368
/// </summary>
public abstract class Espadarana : Centrolenidae, IEspadarana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Espadarana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 715368;

    /// <inheritdoc />
    public virtual string GenusName => "Espadarana";

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
