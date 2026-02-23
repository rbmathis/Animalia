using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Bryconexodon;

/// <summary>
/// Abstract class for Bryconexodon (genus).
/// NCBI TaxId: 2608207
/// </summary>
public abstract class Bryconexodon : Characidae, IBryconexodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bryconexodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608207;

    /// <inheritdoc />
    public virtual string GenusName => "Bryconexodon";

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
