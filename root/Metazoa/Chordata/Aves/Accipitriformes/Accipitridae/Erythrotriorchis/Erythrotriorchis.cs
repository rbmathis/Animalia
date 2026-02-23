using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Erythrotriorchis;

/// <summary>
/// Abstract class for Erythrotriorchis (genus).
/// NCBI TaxId: 1458043
/// </summary>
public abstract class Erythrotriorchis : Accipitridae, IErythrotriorchis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erythrotriorchis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1458043;

    /// <inheritdoc />
    public virtual string GenusName => "Erythrotriorchis";

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
