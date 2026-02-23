using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Ramphastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Ramphastidae.Aulacorhynchus;

/// <summary>
/// Abstract class for Aulacorhynchus (genus).
/// NCBI TaxId: 57398
/// </summary>
public abstract class Aulacorhynchus : Ramphastidae, IAulacorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aulacorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57398;

    /// <inheritdoc />
    public virtual string GenusName => "Aulacorhynchus";

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
