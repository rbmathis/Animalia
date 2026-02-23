using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Mesocottus;

/// <summary>
/// Abstract class for Mesocottus (genus).
/// NCBI TaxId: 1382204
/// </summary>
public abstract class Mesocottus : Cottidae, IMesocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1382204;

    /// <inheritdoc />
    public virtual string GenusName => "Mesocottus";

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
