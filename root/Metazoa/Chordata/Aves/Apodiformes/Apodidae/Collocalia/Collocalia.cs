using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Collocalia;

/// <summary>
/// Abstract class for Collocalia (genus).
/// NCBI TaxId: 46489
/// </summary>
public abstract class Collocalia : Apodidae, ICollocalia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Collocalia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46489;

    /// <inheritdoc />
    public virtual string GenusName => "Collocalia";

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
