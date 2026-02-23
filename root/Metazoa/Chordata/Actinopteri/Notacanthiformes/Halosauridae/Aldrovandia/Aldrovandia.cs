using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Halosauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Halosauridae.Aldrovandia;

/// <summary>
/// Abstract class for Aldrovandia (genus).
/// NCBI TaxId: 143899
/// </summary>
public abstract class Aldrovandia : Halosauridae, IAldrovandia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aldrovandia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143899;

    /// <inheritdoc />
    public virtual string GenusName => "Aldrovandia";

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
