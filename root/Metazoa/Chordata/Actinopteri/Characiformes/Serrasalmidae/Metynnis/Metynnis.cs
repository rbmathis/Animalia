using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Metynnis;

/// <summary>
/// Abstract class for Metynnis (genus).
/// NCBI TaxId: 42496
/// </summary>
public abstract class Metynnis : Serrasalmidae, IMetynnis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Metynnis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42496;

    /// <inheritdoc />
    public virtual string GenusName => "Metynnis";

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
