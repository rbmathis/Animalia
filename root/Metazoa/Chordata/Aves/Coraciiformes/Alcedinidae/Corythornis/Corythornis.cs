using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Corythornis;

/// <summary>
/// Abstract class for Corythornis (genus).
/// NCBI TaxId: 1977157
/// </summary>
public abstract class Corythornis : Alcedinidae, ICorythornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corythornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1977157;

    /// <inheritdoc />
    public virtual string GenusName => "Corythornis";

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
