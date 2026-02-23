using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Quietula;

/// <summary>
/// Abstract class for Quietula (genus).
/// NCBI TaxId: 185747
/// </summary>
public abstract class Quietula : Gobiidae, IQuietula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Quietula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 185747;

    /// <inheritdoc />
    public virtual string GenusName => "Quietula";

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
