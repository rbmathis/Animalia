using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Megatriorchis;

/// <summary>
/// Abstract class for Megatriorchis (genus).
/// NCBI TaxId: 1458046
/// </summary>
public abstract class Megatriorchis : Accipitridae, IMegatriorchis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megatriorchis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1458046;

    /// <inheritdoc />
    public virtual string GenusName => "Megatriorchis";

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
