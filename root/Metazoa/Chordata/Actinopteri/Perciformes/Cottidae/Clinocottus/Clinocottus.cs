using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Clinocottus;

/// <summary>
/// Abstract class for Clinocottus (genus).
/// NCBI TaxId: 283632
/// </summary>
public abstract class Clinocottus : Cottidae, IClinocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clinocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 283632;

    /// <inheritdoc />
    public virtual string GenusName => "Clinocottus";

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
