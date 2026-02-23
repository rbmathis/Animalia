using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salvethymus;

/// <summary>
/// Abstract class for Salvethymus (genus).
/// NCBI TaxId: 152108
/// </summary>
public abstract class Salvethymus : Salmonidae, ISalvethymus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Salvethymus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 152108;

    /// <inheritdoc />
    public virtual string GenusName => "Salvethymus";

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
