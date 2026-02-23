using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Cyanopica;

/// <summary>
/// Abstract class for Cyanopica (genus).
/// NCBI TaxId: 193058
/// </summary>
public abstract class Cyanopica : Corvidae, ICyanopica
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyanopica";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 193058;

    /// <inheritdoc />
    public virtual string GenusName => "Cyanopica";

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
