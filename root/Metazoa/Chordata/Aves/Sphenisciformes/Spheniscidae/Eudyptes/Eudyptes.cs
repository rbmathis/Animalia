using AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Eudyptes;

/// <summary>
/// Abstract class for Eudyptes (genus).
/// NCBI TaxId: 9235
/// </summary>
public abstract class Eudyptes : Spheniscidae, IEudyptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eudyptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9235;

    /// <inheritdoc />
    public virtual string GenusName => "Eudyptes";

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
