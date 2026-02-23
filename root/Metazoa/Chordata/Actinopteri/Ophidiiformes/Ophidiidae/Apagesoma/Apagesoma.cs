using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Apagesoma;

/// <summary>
/// Abstract class for Apagesoma (genus).
/// NCBI TaxId: 1843783
/// </summary>
public abstract class Apagesoma : Ophidiidae, IApagesoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apagesoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1843783;

    /// <inheritdoc />
    public virtual string GenusName => "Apagesoma";

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
