using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Naucrates;

/// <summary>
/// Abstract class for Naucrates (genus).
/// NCBI TaxId: 875790
/// </summary>
public abstract class Naucrates : Carangidae, INaucrates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Naucrates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 875790;

    /// <inheritdoc />
    public virtual string GenusName => "Naucrates";

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
