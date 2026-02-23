using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae.Gerygone;

/// <summary>
/// Abstract class for Gerygone (genus).
/// NCBI TaxId: 117202
/// </summary>
public abstract class Gerygone : Acanthizidae, IGerygone
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gerygone";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117202;

    /// <inheritdoc />
    public virtual string GenusName => "Gerygone";

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
