using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Trachinotus;

/// <summary>
/// Abstract class for Trachinotus (genus).
/// NCBI TaxId: 173330
/// </summary>
public abstract class Trachinotus : Carangidae, ITrachinotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachinotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 173330;

    /// <inheritdoc />
    public virtual string GenusName => "Trachinotus";

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
