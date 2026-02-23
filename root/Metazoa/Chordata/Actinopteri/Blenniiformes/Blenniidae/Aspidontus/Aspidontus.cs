using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Aspidontus;

/// <summary>
/// Abstract class for Aspidontus (genus).
/// NCBI TaxId: 587043
/// </summary>
public abstract class Aspidontus : Blenniidae, IAspidontus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aspidontus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 587043;

    /// <inheritdoc />
    public virtual string GenusName => "Aspidontus";

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
