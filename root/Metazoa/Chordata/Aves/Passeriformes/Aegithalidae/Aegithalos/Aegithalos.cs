using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Aegithalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Aegithalidae.Aegithalos;

/// <summary>
/// Abstract class for Aegithalos (genus).
/// NCBI TaxId: 73326
/// </summary>
public abstract class Aegithalos : Aegithalidae, IAegithalos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aegithalos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 73326;

    /// <inheritdoc />
    public virtual string GenusName => "Aegithalos";

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
