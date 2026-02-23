using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Casiornis;

/// <summary>
/// Abstract class for Casiornis (genus).
/// NCBI TaxId: 478622
/// </summary>
public abstract class Casiornis : Tyrannidae, ICasiornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Casiornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 478622;

    /// <inheritdoc />
    public virtual string GenusName => "Casiornis";

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
