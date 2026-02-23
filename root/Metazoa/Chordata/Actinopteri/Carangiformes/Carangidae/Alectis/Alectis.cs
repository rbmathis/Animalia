using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Alectis;

/// <summary>
/// Abstract class for Alectis (genus).
/// NCBI TaxId: 179357
/// </summary>
public abstract class Alectis : Carangidae, IAlectis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alectis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 179357;

    /// <inheritdoc />
    public virtual string GenusName => "Alectis";

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
