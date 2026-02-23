using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Macrodon;

/// <summary>
/// Abstract class for Macrodon (genus).
/// NCBI TaxId: 227977
/// </summary>
public abstract class Macrodon : Sciaenidae, IMacrodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227977;

    /// <inheritdoc />
    public virtual string GenusName => "Macrodon";

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
