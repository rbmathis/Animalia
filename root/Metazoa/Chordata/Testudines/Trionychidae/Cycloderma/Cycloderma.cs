using AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Cycloderma;

/// <summary>
/// Abstract class for Cycloderma (genus).
/// NCBI TaxId: 227463
/// </summary>
public abstract class Cycloderma : Trionychidae, ICycloderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cycloderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227463;

    /// <inheritdoc />
    public virtual string GenusName => "Cycloderma";

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
