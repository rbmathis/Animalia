using AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Chitra;

/// <summary>
/// Abstract class for Chitra (genus).
/// NCBI TaxId: 171797
/// </summary>
public abstract class Chitra : Trionychidae, IChitra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chitra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 171797;

    /// <inheritdoc />
    public virtual string GenusName => "Chitra";

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
