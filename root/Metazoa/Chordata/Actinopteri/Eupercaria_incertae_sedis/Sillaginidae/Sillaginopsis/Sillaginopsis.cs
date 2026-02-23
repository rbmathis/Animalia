using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae.Sillaginopsis;

/// <summary>
/// Abstract class for Sillaginopsis (genus).
/// NCBI TaxId: 270579
/// </summary>
public abstract class Sillaginopsis : Sillaginidae, ISillaginopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sillaginopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270579;

    /// <inheritdoc />
    public virtual string GenusName => "Sillaginopsis";

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
