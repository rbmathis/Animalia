using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Numididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Numididae.Agelastes;

/// <summary>
/// Abstract class for Agelastes (genus).
/// NCBI TaxId: 388967
/// </summary>
public abstract class Agelastes : Numididae, IAgelastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agelastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 388967;

    /// <inheritdoc />
    public virtual string GenusName => "Agelastes";

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
