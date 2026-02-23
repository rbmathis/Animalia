using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Cancelloxus;

/// <summary>
/// Abstract class for Cancelloxus (genus).
/// NCBI TaxId: 941650
/// </summary>
public abstract class Cancelloxus : Clinidae, ICancelloxus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cancelloxus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 941650;

    /// <inheritdoc />
    public virtual string GenusName => "Cancelloxus";

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
