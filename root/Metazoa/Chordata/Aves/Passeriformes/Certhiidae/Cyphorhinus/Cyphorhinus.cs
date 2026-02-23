using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Cyphorhinus;

/// <summary>
/// Abstract class for Cyphorhinus (genus).
/// NCBI TaxId: 137990
/// </summary>
public abstract class Cyphorhinus : Certhiidae, ICyphorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyphorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 137990;

    /// <inheritdoc />
    public virtual string GenusName => "Cyphorhinus";

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
