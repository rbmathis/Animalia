using AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Eudyptula;

/// <summary>
/// Abstract class for Eudyptula (genus).
/// NCBI TaxId: 37082
/// </summary>
public abstract class Eudyptula : Spheniscidae, IEudyptula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eudyptula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37082;

    /// <inheritdoc />
    public virtual string GenusName => "Eudyptula";

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
