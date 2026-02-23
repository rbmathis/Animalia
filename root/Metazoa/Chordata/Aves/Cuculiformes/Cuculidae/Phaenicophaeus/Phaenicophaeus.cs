using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Phaenicophaeus;

/// <summary>
/// Abstract class for Phaenicophaeus (genus).
/// NCBI TaxId: 33594
/// </summary>
public abstract class Phaenicophaeus : Cuculidae, IPhaenicophaeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phaenicophaeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33594;

    /// <inheritdoc />
    public virtual string GenusName => "Phaenicophaeus";

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
