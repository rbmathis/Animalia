using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Crithagra;

/// <summary>
/// Abstract class for Crithagra (genus).
/// NCBI TaxId: 1892169
/// </summary>
public abstract class Crithagra : Fringillidae, ICrithagra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crithagra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1892169;

    /// <inheritdoc />
    public virtual string GenusName => "Crithagra";

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
