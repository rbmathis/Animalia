using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Toxotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Toxotidae.Toxotes;

/// <summary>
/// Abstract class for Toxotes (genus).
/// NCBI TaxId: 270536
/// </summary>
public abstract class Toxotes : Toxotidae, IToxotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Toxotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270536;

    /// <inheritdoc />
    public virtual string GenusName => "Toxotes";

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
