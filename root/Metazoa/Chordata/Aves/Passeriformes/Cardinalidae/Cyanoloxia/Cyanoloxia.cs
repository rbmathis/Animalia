using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Cyanoloxia;

/// <summary>
/// Abstract class for Cyanoloxia (genus).
/// NCBI TaxId: 460173
/// </summary>
public abstract class Cyanoloxia : Cardinalidae, ICyanoloxia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyanoloxia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 460173;

    /// <inheritdoc />
    public virtual string GenusName => "Cyanoloxia";

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
