using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae.Sargocentron;

/// <summary>
/// Abstract class for Sargocentron (genus).
/// NCBI TaxId: 47707
/// </summary>
public abstract class Sargocentron : Holocentridae, ISargocentron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sargocentron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 47707;

    /// <inheritdoc />
    public virtual string GenusName => "Sargocentron";

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
