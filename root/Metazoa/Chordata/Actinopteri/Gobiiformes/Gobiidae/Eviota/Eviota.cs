using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Eviota;

/// <summary>
/// Abstract class for Eviota (genus).
/// NCBI TaxId: 166746
/// </summary>
public abstract class Eviota : Gobiidae, IEviota
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eviota";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166746;

    /// <inheritdoc />
    public virtual string GenusName => "Eviota";

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
