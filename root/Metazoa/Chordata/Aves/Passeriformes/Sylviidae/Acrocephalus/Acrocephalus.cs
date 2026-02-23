using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Acrocephalus;

/// <summary>
/// Abstract class for Acrocephalus (genus).
/// NCBI TaxId: 39620
/// </summary>
public abstract class Acrocephalus : Sylviidae, IAcrocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acrocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39620;

    /// <inheritdoc />
    public virtual string GenusName => "Acrocephalus";

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
