using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Habia;

/// <summary>
/// Abstract class for Habia (genus).
/// NCBI TaxId: 62200
/// </summary>
public abstract class Habia : Cardinalidae, IHabia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Habia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62200;

    /// <inheritdoc />
    public virtual string GenusName => "Habia";

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
