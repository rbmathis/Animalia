using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mohoidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mohoidae.Moho;

/// <summary>
/// Abstract class for Moho (genus).
/// NCBI TaxId: 572097
/// </summary>
public abstract class Moho : Mohoidae, IMoho
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Moho";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 572097;

    /// <inheritdoc />
    public virtual string GenusName => "Moho";

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
