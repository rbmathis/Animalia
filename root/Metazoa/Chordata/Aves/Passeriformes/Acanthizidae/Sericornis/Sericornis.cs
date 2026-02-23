using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae.Sericornis;

/// <summary>
/// Abstract class for Sericornis (genus).
/// NCBI TaxId: 27581
/// </summary>
public abstract class Sericornis : Acanthizidae, ISericornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sericornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27581;

    /// <inheritdoc />
    public virtual string GenusName => "Sericornis";

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
