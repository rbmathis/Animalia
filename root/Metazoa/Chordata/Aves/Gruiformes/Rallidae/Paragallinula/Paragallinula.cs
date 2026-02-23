using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Paragallinula;

/// <summary>
/// Abstract class for Paragallinula (genus).
/// NCBI TaxId: 3092322
/// </summary>
public abstract class Paragallinula : Rallidae, IParagallinula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paragallinula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3092322;

    /// <inheritdoc />
    public virtual string GenusName => "Paragallinula";

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
