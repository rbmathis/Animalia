using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Astronotus;

/// <summary>
/// Abstract class for Astronotus (genus).
/// NCBI TaxId: 50732
/// </summary>
public abstract class Astronotus : Cichlidae, IAstronotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Astronotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50732;

    /// <inheritdoc />
    public virtual string GenusName => "Astronotus";

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
