using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Petropedetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Petropedetidae.Arthroleptides;

/// <summary>
/// Abstract class for Arthroleptides (genus).
/// NCBI TaxId: 2763318
/// </summary>
public abstract class Arthroleptides : Petropedetidae, IArthroleptides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arthroleptides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2763318;

    /// <inheritdoc />
    public virtual string GenusName => "Arthroleptides";

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
