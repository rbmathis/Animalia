using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Centriscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Centriscidae.Macroramphosus;

/// <summary>
/// Abstract class for Macroramphosus (genus).
/// NCBI TaxId: 206123
/// </summary>
public abstract class Macroramphosus : Centriscidae, IMacroramphosus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macroramphosus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206123;

    /// <inheritdoc />
    public virtual string GenusName => "Macroramphosus";

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
