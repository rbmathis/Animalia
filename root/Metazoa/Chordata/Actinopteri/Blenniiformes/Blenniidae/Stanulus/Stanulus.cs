using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Stanulus;

/// <summary>
/// Abstract class for Stanulus (genus).
/// NCBI TaxId: 1156474
/// </summary>
public abstract class Stanulus : Blenniidae, IStanulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stanulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1156474;

    /// <inheritdoc />
    public virtual string GenusName => "Stanulus";

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
