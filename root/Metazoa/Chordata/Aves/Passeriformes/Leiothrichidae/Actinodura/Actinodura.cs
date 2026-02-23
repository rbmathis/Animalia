using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Actinodura;

/// <summary>
/// Abstract class for Actinodura (genus).
/// NCBI TaxId: 181642
/// </summary>
public abstract class Actinodura : Leiothrichidae, IActinodura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Actinodura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181642;

    /// <inheritdoc />
    public virtual string GenusName => "Actinodura";

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
