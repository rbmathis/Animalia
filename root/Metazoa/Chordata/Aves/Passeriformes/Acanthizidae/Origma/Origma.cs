using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae.Origma;

/// <summary>
/// Abstract class for Origma (genus).
/// NCBI TaxId: 720585
/// </summary>
public abstract class Origma : Acanthizidae, IOrigma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Origma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 720585;

    /// <inheritdoc />
    public virtual string GenusName => "Origma";

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
